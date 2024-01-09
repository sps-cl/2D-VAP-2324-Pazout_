let radky = document.getElementById("pocet-radku");
let sloupce = document.getElementById("pocet-sloupcu");

let table ;
let hoto = 0
function vytvoritTabulku() {
    let bunka=0
    if (hoto==1) {
        table.remove();
    }

    let pocetRadku = radky.value;
    let pocetslopcu = sloupce.value
    table = document.createElement("table");
    for (let i = 0; i < pocetRadku; i++) {
        let row = table.insertRow(i);
        for (let j = 0; j < pocetslopcu; j++) {
            let cell = row.insertCell(j)
            bunka++
            cell.textContent = bunka
        }
    }
    document.body.appendChild(table)
    hoto = 1
}