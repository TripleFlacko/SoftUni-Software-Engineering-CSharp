function solve(grade) {
    let gradeDescription = '';
    
    if (grade < 3) {
        gradeDescription = `Fail (2)`;
    } else if (grade < 3.50) {
        gradeDescription = `Poor (${grade.toFixed(2)})`;
    } else if (grade < 4.50) {
        gradeDescription = `Good (${grade.toFixed(2)})`;
    } else if (grade < 5.50) {
        gradeDescription = `Very good (${grade.toFixed(2)})`;
    } else {
        gradeDescription = `Excellent (${grade.toFixed(2)})`;
    }

    console.log(gradeDescription);
}
 
solve(2.91);