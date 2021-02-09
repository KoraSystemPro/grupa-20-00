function napraviNoviElement(){
    let noviLi = document.createElement("li");
    noviLi.classList.add("todo");
    let ulazniTekst = document.getElementById("inputSadrzaj").value;
    let ulazCvor = document.createTextNode(ulazniTekst);
    noviLi.appendChild(ulazCvor);

    let lista = document.getElementById("todoLista");
    if(ulazniTekst == ""){
    //    alert("Morate upisati neku vrednost!"); 
    } else {
        lista.appendChild(noviLi);
    }
    // Skidamo ga sa input boxa kada ga dodamo
    document.getElementById("inputSadrzaj").value = "";

    // Pravimo X i dodeljujemo ga na li
    let iksic = document.createElement("span");
    iksic.className = "zatvori";
    iksic.appendChild(document.createTextNode("\u2716"));
    noviLi.appendChild(iksic);
    
    // Za svaki clan liste pravimo X koje ce da ga skine sa iste
    let iksici = document.getElementsByClassName("zatvori");
    for(let i = 0; i < iksici.length; i++){
        iksici[i].addEventListener("click", ukolniElement);
    }
    
}

function ukolniElement(){
    let otac = this.parentElement;
    otac.style.display = "none";
}

document.getElementById("todoLista").addEventListener("click", function(dogadjaj){
    console.log(dogadjaj.target.tagName);
    if(dogadjaj.target.tagName == "LI"){
        dogadjaj.target.classList.toggle("gotovo");
    }
});

document.getElementById("dgmDodaj").addEventListener("click", napraviNoviElement);
document.getElementById("inputSadrzaj").addEventListener("keypress", function(e){
    if(e.key == "Enter"){
        napraviNoviElement();
    }
});
