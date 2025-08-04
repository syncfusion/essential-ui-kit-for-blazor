const resizeListenersMap = new Map();

window.scrollToElement = function (fragment) {
    const element = document.getElementById(fragment);
    if (element) {
        element.scrollIntoView({ behavior: "instant" });
    }
};

window.initializeHighlightJs = function () {
    var languages = ['language-html', 'language-css', 'language-csharp'];

    languages.forEach(language => {
        var elements = document.querySelectorAll(`.${language}:not(.hljs)`);
        elements.forEach(element => {
            hljs.highlightElement(element);
        });
    });

};

window.copyToClipboard = function (e) {
    var blockContainer = e.target.closest('.main-container').parentElement;
    var code = blockContainer.querySelector("div.preview-code-container div.tab-content.active textarea").value;
    navigator.clipboard.writeText(code)
        .then(() => showTooltip(blockContainer))
        .catch((error) => console.error("Error copying text: ", error));
};

window.showTooltip = function (blockContainer) {
    if (blockContainer) {
        const tooltip = blockContainer.querySelector(".tooltip");
        const buttonRect = blockContainer.querySelector(".copy-button").getBoundingClientRect();

        tooltip.style.top = `${buttonRect.bottom + window.scrollY + 5}px`;
        tooltip.style.left = `${buttonRect.left + window.scrollX - 40}px`;
        tooltip.classList.add("show");

        setTimeout(() => tooltip.classList.remove("show"), 2000);
    }
};

window.updateStyleSheet = function (previewElement, themeName, className, isPreviewRefresh) {
    const previewDocument = getPreviewDocument(previewElement);
    if (!previewDocument) return false;

    if (["tailwind-light", "bootstrap5.3-light"].includes(themeName)) {
        removeDarkModeClass(previewDocument, className);
    } else {
        addDarkModeClass(previewDocument, className);
    }
    if (isPreviewRefresh) {
        updatePreviewHeight(previewElement);
        previewDocumentResizeHandler(previewElement);
    }
    else {
        previewElement.contentWindow.postMessage({ type: "resizeAction" });
    }
    return true;
};

window.getPreviewDocument = function (previewElement) {
    return previewElement.contentDocument || previewElement.contentWindow.document;
};

window.addDarkModeClass = function (previewDocument, className) {
    if (previewDocument?.body) {
        previewDocument.body.classList.add(className);

        if (className === "bs-theme-dark") {
            previewDocument.documentElement.setAttribute("data-bs-theme", "dark");
        }
    }
};

window.removeDarkModeClass = function (previewDocument, className) {
    if (previewDocument?.body) {
        previewDocument.body.classList.remove(className);

        if (className === "bs-theme-dark") {
            previewDocument.documentElement.setAttribute("data-bs-theme", "light");
        }
    }
};

window.updatePreviewHeight = function (previewEement) {
    const previewDocument = getPreviewDocument(previewEement);
    if (!previewDocument) return false;

    const contentHeight = previewDocument.body.scrollHeight || previewDocument.documentElement.scrollHeight;
    previewEement.style.height = `${contentHeight + 1}px`;

    return true;
};

window.previewDocumentResizeHandler = function (previewElement) {
    const resizeEventListener = window.debounce(() => {
        window.onResize(previewElement);
    }, 100);

    resizeListenersMap.set(previewElement, resizeEventListener);

    window.addEventListener('resize', resizeEventListener);
}

window.debounce = function (func, wait, previewElement) {
    let timeout;

    return function (...args) {
        const context = this;

        const later = function () {
            timeout = null;
            func.apply(context, previewElement);
        };

        clearTimeout(timeout);
        timeout = setTimeout(later, wait);
    };
}

window.onResize = function (previewElement) {
    if (previewElement && previewElement.contentWindow) {
        previewElement.contentWindow.postMessage({ type: "resizeAction" });
    }
}

window.initializeiFrameMessageListener = (dotNetRef) => {
    const messageEventListener = (event) => {
        if (event.origin !== window.location.origin || event.data.type !== "resizeAction") {
            return;
        }
        invokeResizeHandler(dotNetRef);
    };

    window.addEventListener("message", messageEventListener);

    window.messageEventListener = messageEventListener;
    invokeResizeHandler(dotNetRef);
};

window.invokeResizeHandler = (dotNetRef) => {
    dotNetRef.invokeMethodAsync("ResizeHandler", "resizeAction", window.innerWidth).catch(() => { }).then(() => {
        updatePreviewHeight(window.frameElement);
        window.parent.postMessage("resizeCompleted", window.location.origin);
    });
}

window.initializeDemoMessageListener = (dotNetRef) => {
    const demoMessageEventListener = (event) => {
        if (event.origin !== window.location.origin) {
            return;
        }
        if (event.data === "resizeCompleted") {
            dotNetRef.invokeMethodAsync("ToggleLoadingIndicator", false).catch(() => { });
        }
    };

    window.addEventListener("message", demoMessageEventListener);
    window.demoMessageEventListener = demoMessageEventListener;
}

window.removeMessageListener = (previewElement) => {
    window.removeEventListener("message", window.messageEventListener);
    const resizeEventListener = resizeListenersMap.get(previewElement);
    if (resizeEventListener) {
        window.removeEventListener('resize', resizeEventListener);
        resizeListenersMap.delete(previewElement);
    }
    if (window.demoMessageEventListener) {
        window.removeEventListener("message", window.demoMessageEventListener);
    }
};