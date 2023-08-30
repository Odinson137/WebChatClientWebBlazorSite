function scrollToBottom(element) {
    console.log(element);
    const lastChild = element.lastElementChild;
    if (lastChild) {
        lastChild.scrollIntoView({ behavior: "smooth" });
    }
}
