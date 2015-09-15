function onButtonClick(event) {
    var currentWindow = window;
    var browserName = currentWindow.navigator.appCodeName;

    if (browserName == "Mozilla") {
        alert("Yes");
    }
    else {
        alert("No");
    }
}
