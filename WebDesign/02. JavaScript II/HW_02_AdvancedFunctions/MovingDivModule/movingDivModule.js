var movingShapes = (function () {

    function randomNum(start, end) {
        return Math.floor(Math.random() * (end - start + 1)) + start;
    }

    function randomColor() {
        return 'rgba(' + randomNum(0, 255) + ', ' +
            randomNum(0, 255) + ', ' +
            randomNum(0, 255) + ', ' +
            randomNum(0, 255) + ')';
    }

    function createEl() {
        var square = document.createElement('div');
        square.style.width = 30 + 'px';
        square.style.height = 30 + 'px';
        square.style.borderStyle = "solid";
        square.style.borderColor = randomColor();
        square.style.backgroundColor = randomColor();
        square.style.position = 'absolute';
        square.style.borderRadius = 30 + 'px';
        square.style.textAlign = "center";
        square.style.color = randomColor();
        square.innerHTML = "div";

        return square;
    }

    function add(type) {

        if (type === "circle") {
            var div = createEl();
            document.body.appendChild(div);

            function circMotion(element) {
                element.setAttribute("angleAttr", "0");
                element.style.left = "700px";
                element.style.top = "300px";

                setInterval(function () {
                    var angleInRadians = (element.getAttribute("angleAttr")) * (Math.PI / 180);
                    var left = 80 * Math.cos(angleInRadians) + 400;
                    var top = 80 * Math.sin(angleInRadians) + 130;
                    console.log(angleInRadians);
                    element.style.left = left + "px";
                    element.style.top = top + "px";
                    element.attributes.angleAttr.nodeValue++;
                }, 8);
            }

            circMotion(div);
        }
        else if (type === "square") {

            var div = createEl();
            document.body.appendChild(div);

            function squareMotion(element) {
                var top = 50;
                var left = 50;

                setInterval(function () {
                    if (top <= 200 && left == 50) {
                        top++;
                    } else if (left <= 200 && top > 199) {
                        left++;
                    } else if (left > 199 && top >= 50) {
                        top--;
                    } else if (top < 51 && left >= 50) {
                        left--;
                    }

                    element.style.top = top + "px";
                    element.style.left = left + "px";
                }, 8);
            }

            squareMotion(div);
        }
    }

    return {
        add: add
    }
})();