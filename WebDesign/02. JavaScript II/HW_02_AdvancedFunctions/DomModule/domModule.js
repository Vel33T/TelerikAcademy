(function () {
    'use strict'

    var domModule = (function () {

        var buffer = {};
        var MAX_BUFFER_SIZE = 100;

        function createElement(tagName, attributes, innerHTML) {
            var child = document.createElement(tagName);

            for (var name in attributes) {
                child.setAttribute(name, attributes[name]);
            }

            child.innerHTML = innerHTML;
            return child;
        }

        function getElement(selector) {
            return document.querySelector(selector);
        }

        function getElements(selector) {
            return document.querySelectorAll(selector);
        }

        function appendChild(parentSelector, tagName, attributes, innerHTML) {
            var parent = getElement(parentSelector);
            var child = createElement(tagName, attributes, innerHTML);

            parent.appendChild(child);
        }

        function removeChild(parentSelector, childSelector) {
            var elementsToRemove = getElements(parentSelector + " " + childSelector);

            for (var i = 0; i < elementsToRemove; i++) {
                elementsToRemove[i].parentNode.removeChild(elementsToRemove[i]);
            }
        }

        function addHandler(selector, eventType, handler) {
            var element = getElement(selector);
            if (element.addEventListener) {
                element.addEventListener(eventType, handler, false);
            }
            else {
                element.attachEvent("on" + eventType, handler);
            }
        }

        function appendToBuffer(parentSelector, tagName, attributes, innerHTML) {
            if (!buffer[parentSelector]) {
                buffer[parentSelector] = document.createDocumentFragment();
            }

            var element = createElement(tagName, attributes, innerHTML);
            buffer[parentSelector].appendChild(element);

            if (buffer[parentSelector].childNodes.length === MAX_BUFFER_SIZE) {
                var parent = getElement(parentSelector);
                parent.appendChild(buffer[parentSelector]);

                buffer[parentSelector] = null;
            }
        }

        return {
            getElement: getElement,
            getElements: getElements,
            appendChild: appendChild,
            removeChild: removeChild,
            addHandler: addHandler,
            appendToBuffer: appendToBuffer
        };
    })();
})();