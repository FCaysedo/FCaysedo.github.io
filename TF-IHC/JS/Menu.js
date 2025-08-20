const banner=document.querySelector("#banner")
const servicios = document.querySelector("#servicios")
const contactanos= document.querySelector("#contactanos")
const IniciarSesion=document.querySelector("#IniciarSesion")
const Registro=document.querySelector("#Registro")


/*Menu servicios*/
banner.addEventListener("click", (b)=>{
    b.defaultPrevented();

    const sectionB=document.querySelector(".banner");
    sectionB.scrollIntoView({behavior:"smooth"});
})
servicios.addEventListener("click", (s)=>{
    s.defaultPrevented();

    const sectionS=document.querySelector(".servicios");
    sectionS.scrollIntoView({behavior:"smooth"});
})
contactanos.addEventListener("click", (c)=>{
    c.defaultPrevented();

    const sectionC=document.querySelector(".contactanos");
    sectionC.scrollIntoView({behavior:"smooth"});
})
IniciarSesion.addEventListener("click", (is)=>{
    is.defaultPrevented();

    const sectionIS=document.querySelector(".IniciarSesion");
    sectionIS.scrollIntoView({behavior:"smooth"});
})
Registro.addEventListener("click", (r)=>{
    r.defaultPrevented();

    const sectionR=document.querySelector(".Registro");
    sectionR.scrollIntoView({behavior:"smooth"});
})