var prsten;

function azurirajMatrijalIzKanvasa(kanvas){
    let canvTekstura = new THREE.CanvasTexture(kanvas);
    let materijal = new THREE.MeshStandardMaterial({
        map: canvTekstura,
        displacementMap: canvTekstura, 
        displacementScale: 0.8,
    });

    prsten.material = materijal;
    prsten.material.needsUpdate = true;
}

function generisiZvezdanoNebo(brojZvezda, sirina, visina){
    let canv = document.createElement("canvas");
    canv.width = sirina;
    canv.height = visina;
    let ctx = canv.getContext('2d');

    ctx.fillStyle = "black";
    ctx.fillRect(0, 0, sirina, visina);

    
    ctx.fillStyle = "white";
    for(let i = 0; i < brojZvezda; i++){
            
        let x = Math.floor(Math.random() * sirina);
        let y = Math.floor(Math.random() * visina);
        let r = Math.floor(Math.random() * 3) + 1;  // 1 - 4

        ctx.beginPath();
        ctx.arc(x, y, r, 0, 2 * Math.PI);
        ctx.fill();
    }

    let neboTekstura = new THREE.CanvasTexture(canv);
    return neboTekstura; 

}

function nacrtajScenu(){
    // Podesavamo scenu i kameru
    const scena = new THREE.Scene();
    const kamera = new THREE.PerspectiveCamera(
        90, window.innerWidth / window.innerHeight, 0.1, 1000
    );
    
    // Podesavamo renderer
    const renderer = new THREE.WebGLRenderer();
    renderer.setSize(window.innerWidth, window.innerHeight);
    document.body.appendChild(renderer.domElement);
    
    // Pravimo objekte za scenu
    const geometrija_prstena = new THREE.TorusGeometry(10, 5, 150, 300);
    const material = new THREE.MeshStandardMaterial({color: 0x666666});
    prsten = new THREE.Mesh(geometrija_prstena, material);
    
    // SkyBox
    const skyBox = new THREE.BoxGeometry(300, 300, 300);
    const skyBoxMatrijal = new THREE.MeshBasicMaterial({
        map: generisiZvezdanoNebo(600, 1000, 1000),
        side: THREE.BackSide,
    });
    const sky = new THREE.Mesh(skyBox, skyBoxMatrijal);

    // Svetlo
    const svetlo1 = new THREE.PointLight(0xABD1F7, 30, 100);
    const svetlo2 = new THREE.PointLight(0xC72F31, 30, 100);
    svetlo1.position.set(40, 30, 20);
    svetlo2.position.set(-60, -20, 20);

    const grupa = new THREE.Group();
    grupa.add(prsten);
    grupa.add(sky);

    // Dodavanje na scenu
    scena.add(svetlo1);
    scena.add(svetlo2);
    scena.add(grupa);
    
    kamera.position.z = 30;
    
    const animate = function(){
        grupa.rotation.x += 0.005;
        grupa.rotation.y += 0.005;

        requestAnimationFrame(animate);
        renderer.render(scena, kamera);
    }
    animate();
    
}