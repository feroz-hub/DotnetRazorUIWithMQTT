

// show or hide sidebar //

//const menuBtn = document.querySelector('#menu-btn');
//const closeBtn = document.querySelector('#close-btn');
//const sidebar = document.querySelector('aside');

// menuBtn.addEventListener('click', () => {
//     sidebar.style.display = 'block';
// })
// closeBtn.addEventListener('click', () => {
//     sidebar.style.display = 'none';
// })

// change theme //
const themeBtn = document.querySelector('.theme-btn');

themeBtn.addEventListener('click', () => {
    document.body.classList.toggle('dark-theme');

    themeBtn.querySelector('span:first-child').classList.toggle('active');
    themeBtn.querySelector('span:last-child').classList.toggle('active');
})

document.getElementById('select-all').addEventListener('change',function() {
    const checkboxes = document.querySelectorAll('.select-client');
    for(const checkbox of checkboxes)
    {
        checkbox.checked = this.checked;
    }
});

let sidebar = document.querySelector(".sidebar");
let closeBtn = document.querySelector("#btn");
let searchBtn = document.querySelector(".bx-search");

closeBtn.addEventListener("click", ()=>{
    sidebar.classList.toggle("open");
    menuBtnChange();//calling the function(optional)
});

searchBtn.addEventListener("click", ()=>{ // Sidebar open when you click on the search iocn
    sidebar.classList.toggle("open");
    menuBtnChange(); //calling the function(optional)
});

function menuBtnChange() {
    if(sidebar.classList.contains("open")){
        closeBtn.classList.replace("bx-menu", "bx-menu-alt-right");//replacing the iocns class
    }else {
        closeBtn.classList.replace("bx-menu-alt-right","bx-menu");//replacing the iocns class
    }
}