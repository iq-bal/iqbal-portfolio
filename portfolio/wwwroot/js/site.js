const menuIcon = document.querySelector(".toggle");
const mobileMenu = document.querySelector(".navMenu");

menuIcon.onclick = function () {
    if (mobileMenu.style.display != "block") {
        mobileMenu.style.display = "block";
        menuIcon.classList.replace("uil-bars", "uil-multiply")
    }
    else {
        mobileMenu.style.display = "none";
        menuIcon.classList.replace("uil-multiply", "uil-bars")
    }
}

// Circular Chart
jQuery(document).ready(function () {
    jQuery('.skillbar').each(function () {
        jQuery(this).find('.skillbar-bar').animate({
            width: jQuery(this).attr('data-percent')
        }, 3000);
    });
});






//contact form js
const checkbox = document.querySelector('.my-form input[type="checkbox"]');
const btns = document.querySelectorAll(".my-form button");

checkbox.addEventListener("change", function () {
    const checked = this.checked;
    for (const btn of btns) {
        checked ? (btn.disabled = false) : (btn.disabled = true);
    }
});