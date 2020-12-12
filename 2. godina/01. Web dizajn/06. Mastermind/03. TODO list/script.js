function napraviNoviElement(){
    let noviLi = document.createElement("li");
    let ulazniTekst = document.getElementById("inputSadrzaj").value;
    let ulazCvor = document.createTextNode(ulazniTekst);
    noviLi.appendChild(ulazCvor);

    let lista = document.getElementById("todoLista");
    if(ulazniTekst == ""){
    //    alert("Morate upisati neku vrednost!"); 
    } else {
        lista.appendChild(noviLi);
    }

    // Pravimo X i dodeljujemo ga na li
    let iksic = document.createElement("span");
    iksic.className = "zatvori";
    iksic.appendChild(document.createTextNode("X"));
    noviLi.appendChild(iksic);
    
    // Za svaki clan liste pravimo X koje ce da ga skine sa iste
    let iksici = document.getElementsByClassName("zatvori");
    for(let i = 0; i < iksici.length; i++){
        iksici[i].addEventListener("click", ukolniElement);
    }
    console.log(iksici);
    
    
}

function ukolniElement(){
    let otac = this.parentElement;
    otac.style.display = "none";
}

document.getElementById("dgmDodaj").addEventListener("click", napraviNoviElement);
