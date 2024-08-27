function solve() {
    const input = document.querySelector('input');
    const result = document.querySelector('#result');

    const button = document.querySelector('#container button');
    button.addEventListener('click', onClick);

    const selectMenuTo = document.querySelector('#selectMenuTo');
    const optionBinary = document.querySelector('#selectMenuTo option');
    optionBinary.value = 'binary';
    optionBinary.textContent = 'Binary';

    const optionHexadecimal = document.createElement('option');
    optionHexadecimal.value = 'hexadecimal';
    optionHexadecimal.textContent = 'Hexadecimal';

    selectMenuTo.appendChild(optionHexadecimal);

    function onClick() {
        const convertTo = selectMenuTo.value;
        
        switch (convertTo) {
            case 'binary':
                result.value = convertToBinary(Number(input.value));
                break;
        
            case 'hexadecimal':
                result.value = convertToHexadecimal(Number(input.value));
                break;
        }
    }

    function convertToBinary(number) {
        const binaryNumber = number.toString(2);
        return binaryNumber;
    }

    function convertToHexadecimal(number) {
        const hexadecimalNumber = number.toString(16).toUpperCase();
        return hexadecimalNumber;
    }
}