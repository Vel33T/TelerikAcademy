function doMagic() {
    var browserName = navigator.appName;
    var addScroll = false;

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }

    var positionX = 0;
    var positionY = 0;

    document.onmousemove = mouseMove;
    if (browserName == "Netscape") {
        document.captureEvents(Event.MOUSEMOVE);
    }

    function mouseMove(event) {
        if (browserName == "Netscape") {
            positionX = event.pageX - 5;
            positionY = event.pageY;
        }
        else {
            positionX = event.x - 5;
            positionY = event.y;
        }

        if (browserName == "Netscape") {
            if (document.layers.ToolTip.visibility == 'show') {
                popTip();
            }
        }
        else {
            if (document.all.ToolTip.style.visibility == 'visible') {
                popTip();
            }
        }
    }

    function popTip() {
        if (browserName == "Netscape") {
            theLayer = document.layers.ToolTip;

            if ((positionX + 120) > window.innerWidth) {
                positionX = window.innerWidth - 150;
            }

            theLayer.left = positionX + 10;
            theLayer.top = positionY + 15;
            theLayer.visibility = 'show';
        }
        else {
            theLayer = document.layers.ToolTip;
            if (theLayer) {
                positionX = event.x - 5;
                positionY = event.y;

                if (addScroll) {
                    positionX = positionX + document.body.scrollLeft;
                    positionY = positionY + document.body.scrollTop;
                }

                if ((positionX + 120) > document.body.clientWidth) {
                    positionX = positionX - 150;
                }

                theLayer.style.pixelLeft = positionX + 10;
                theLayer.style.pixelTop = positionY + 15;
                theLayer.style.visibility = 'visible';
            }
        }
    }

    function hideTip() {
        args = hideTip.arguments;
        if (browserName == "Netscape") {
            document.layers.ToolTip.visibility = 'hide';
        }
        else {
            document.all.ToolTip.style.visibility = 'hidden';
        }
    }

    function hideMenu1() {
        if (browserName == "Netscape") {
            document.layers.menu1.visibility = 'hide';
        }
        else {
            document.all.menu1.style.visibility = 'hidden';
        }
    }

    function showMenu1() {
        if (browserName == "Netscape") {
            theLayer = document.layers.menu1;
            theLayer.visibility = 'show';
        }
        else {
            theLayer = document.layers.menu1;
            theLayer.style.visibility = 'visible';
        }
    }

    function hideMenu2() {
        if (browserName == "Netscape") {
            document.layers.menu2.visibility = 'hide';
        }
        else {
            document.all.menu2.style.visibility = 'hidden';
        }
    }

    function showMenu2() {
        if (browserName == "Netscape") {
            theLayer = document.layers.menu2;
            theLayer.visibility = 'show';
        }
        else {
            theLayer = document.layers.menu2;
            theLayer.style.visibility = 'visible';
        }
    }
}