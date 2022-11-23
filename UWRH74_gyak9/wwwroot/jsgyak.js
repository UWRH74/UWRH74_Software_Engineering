window.onload = () => {
    console.log("betöltődött")
}

var faktoriális = function (n) {
    let er = 1;
    for (let i = 2; i <= n; i++) {
        er = er * i;
    }
    return er;
}

function funkcio() {
    for (var sor = 0; sor < 10; ++sor) {
        var új = document.createElement("div");
        új.classList.add("sor");
        document.getElementById("Pascal").appendChild(új);

        for (var oszlop = 0; oszlop <= sor; ++oszlop) {
            var újabb = document.createElement("div");
            újabb.classList.add("elem");
            újabb.innerHTML = (faktoriális(sor)/(faktoriális(oszlop) * faktoriális(sor-oszlop)));
            új.appendChild(újabb);
        }
    }
}
