function toggle() {
    let extraElement = document.getElementById('extra');
    let moreElement = document.querySelector('.head .button');

    if (extraElement.style.display === 'block'){
        extraElement.style.display = 'none';
        moreElement.textContent = 'More';
    } else {
        extraElement.style.display = 'block';
        moreElement.textContent = 'Less';
    }
}