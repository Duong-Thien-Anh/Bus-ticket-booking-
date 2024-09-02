// Tự động thay đổi chiều rộng của menu khi cửa sổ thay đổi kích thước
window.addEventListener("resize", function () {
    var navbar = document.querySelector(".navigations");
    navbar.style.width = "auto"; // Đặt lại chiều rộng ban đầu
    var navbarWidth = navbar.scrollWidth;
    var windowWidth = window.innerWidth;

    if (navbarWidth > windowWidth) {
        navbar.style.width = navbarWidth + "px"; // Thiết lập chiều rộng nếu nội dung quá rộng
    }
});
document.addEventListener('DOMContentLoaded', () => {
    const wrapper = document.querySelector('.wrapper');
    const loginLink = document.querySelector('.login-link');
    const registerLink = document.querySelector('.register-link');
    registerLink.addEventListener('click', () => {
        wrapper.classList.add('active');
    });
    loginLink.addEventListener('click', () => {
        wrapper.classList.remove('active');
    });

});
document.addEventListener('DOMContentLoaded', () => {
    const CardTicketText = document.querySelector('.CardTicketText');
    const vedatlink = document.querySelector('.vedat-link');
    const vehuylink = document.querySelector('.vehuy-link');

    vehuylink.addEventListener('click', () => {
        CardTicketText.classList.add('active');
    });

    vedatlink.addEventListener('click', () => {
        CardTicketText.classList.remove('active');
    });
});
document.addEventListener('DOMContentLoaded', () => {
    const inftimchuyen = document.querySelector('.inf-timchuyen');
    const btnChuyenlink = document.querySelector('.btnChuyen-link');
    const btnCloselink = document.querySelector('.btnClose-link');
    btnChuyenlink.addEventListener('click', () => {
        inftimchuyen.classList.add('active');
    });
    //btnCloselink.addEventListener('click', () => {
    //    inftimchuyen.classList.add('active');
    //});

});
document.getElementById("resizeButton").addEventListener("click", function () {
    var formContainer = document.getElementById("formContainer");
    formContainer.classList.toggle("active");
});

// Đóng form khi bấm nút đóng
function closeForm() {
    var formContainer = document.getElementById("formContainer");
    formContainer.classList.remove("active");
}


