var prsten;

function azurirajMatrijalIzKanvasa(kanvas){
    let canvTekstura = new THREE.CanvasTexture(kanvas);
    let materijal = new THREE.MeshStandardMaterial({
        map: canvTekstura,
        displacementMap: canvTekstura,
        
    });
    prsten.material = materijal;
    prsten.material.needsUpdate = true;
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
    
    // Svetlo
    const svetlo1 = new THREE.PointLight(0xABD1F7, 30, 100);
    const svetlo2 = new THREE.PointLight(0xC72F31, 30, 100);
    svetlo1.position.set(40, 30, 20);
    svetlo2.position.set(-60, -20, 20);

    // Dodavanje na scenu
    scena.add(prsten);
    scena.add(svetlo1);
    scena.add(svetlo2);
    
    kamera.position.z = 40;
    
    const animate = function(){
        prsten.rotation.x += 0.01;
        prsten.rotation.y += 0.01;

        requestAnimationFrame(animate);
        renderer.render(scena, kamera);
    }
    animate();
    
}