// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function filterProducts(category, btn) {
    let cards = document.querySelectorAll('.card');
    let buttons = document.querySelectorAll('.filter button');

    // حذف کلاس فعال از همه دکمه‌ها
    buttons.forEach(b => b.classList.remove('active'));
    // اضافه کردن کلاس فعال به دکمه فعلی
    btn.classList.add('active');

    // فیلتر کردن کارت‌ها بر اساس دسته‌بندی
    cards.forEach(card => {
        if (category === 'all') {
            card.style.display = "block";
        } else {
            card.style.display = card.classList.contains(category) ? "block" : "none";
        }
    });
}

