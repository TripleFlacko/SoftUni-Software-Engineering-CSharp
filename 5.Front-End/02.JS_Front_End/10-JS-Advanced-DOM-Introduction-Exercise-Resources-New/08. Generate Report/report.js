function generateReport() {
    const table = document.querySelector('table');
    const headers = Array.from(document.querySelectorAll('thead th'));
    const rows = document.querySelectorAll('tbody tr');

    const output = document.querySelector('#output');

    const result = [];

    const selectedColumns = headers
    .map((header, index) => {
        const checkbox = header.querySelector('input[type="checkbox"]')

        if (checkbox && checkbox.checked) {
            return {
                name: checkbox.name,
                index: index
            }
        }

        return null;
    })
    .filter(column => column !== null);

    rows.forEach(row => {
        const cells = Array.from(row.querySelectorAll('td'));
        const rowData = {};

        selectedColumns.forEach(column => {
            rowData[column.name] = cells[column.index].textContent.trim();
        })

        result.push(rowData);
    })

    output.value = JSON.stringify(result, null, 2);
}