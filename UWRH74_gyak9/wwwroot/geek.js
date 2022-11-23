window.onload = () => {
    console.log("betöltődött")
}

var viccek;

var letöltés = function () {
    fetch('/jokes.json')
        .then(x => x.json())
        .then(data => letöltésBefejeződött(data)
        );
}

function letöltésBefejeződött(d) {
    console.log("Sikeres letöltés")
    console.log(d)
    viccek = d;

    for (var i = 0; i < viccek.length; ++i) {
        console.log(viccek[i].text);
        let elem = document.createElement("div");
        elem.innerHTML = viccek[i].text;
        ide.appendChild(elem);
    }

}
