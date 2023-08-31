function scrollToBottom(targetNode) {
    const config = { attributes: false, childList: true, subtree: false };
    const callback = function (mutationsList, observer) {
        targetNode.scrollTop = targetNode.scrollHeight
    };

    const observer = new MutationObserver(callback);
    observer.observe(targetNode, config);
}

function autoResize(textarea) {
    textarea.style.height = 'auto';
    textarea.style.height = (textarea.scrollHeight) + 'px';
}
