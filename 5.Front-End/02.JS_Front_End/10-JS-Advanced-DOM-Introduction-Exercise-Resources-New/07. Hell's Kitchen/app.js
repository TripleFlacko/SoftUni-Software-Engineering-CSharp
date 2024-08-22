function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   const outputBestRestaurant = document.querySelector('#bestRestaurant p');
   const outputWorkers = document.querySelector('#workers p');

   let restaurants = {};
   let bestRestaurant = {};
   let highestAverageSalary = -Infinity;
   let highestSalary = -Infinity;

   function onClick() {
      const input = document.querySelector('#inputs textarea').value;
      const parsedData = JSON.parse(input);
      
      createRestaurant(parsedData);
      findBestRestaurant();
      output();
   }

   function createRestaurant(parsedData) {
      for (const restaurantData of parsedData) {
         let [restaurantName, employeesData] = restaurantData.split(' - ');
         let employees = createEmployees(employeesData);

         if (!(restaurantName in restaurants)) {
            restaurants[restaurantName] = employees;
         } else {
            restaurants[restaurantName] = {
               ...restaurants[restaurantName],
               ...employees
            };
         }
      }      
   }

   function createEmployees(employeesData) {
      let employees = {};
      let employeesList = employeesData.split(', ');

      for (const employee of employeesList) {
         let [name, salary] = employee.split(' ');
         employees[name] = Number(salary);
      }

      return employees;
   }

   function findBestRestaurant() {
      for (const restaurantName in restaurants) {
         let employees = restaurants[restaurantName];
         let salariesSum = Object.values(employees).reduce((acc, value) => acc + value, 0);
         let averageSalary = salariesSum / Object.keys(employees).length;

         if (averageSalary > highestAverageSalary) {
            highestAverageSalary = averageSalary;
            bestRestaurant = restaurantName;
         }
      }

      highestSalary = Math.max(...Object.values(restaurants[bestRestaurant]));
   }

   function output() {
      const restaurantName = bestRestaurant;
      const sortedEmployees = Object.entries(restaurants[bestRestaurant]).sort((a, b) => b[1] - a[1]);

      outputBestRestaurant.textContent = `Name: ${restaurantName} Average Salary: ${highestAverageSalary.toFixed(2)} Best Salary: ${highestSalary.toFixed(2)}`;

      let employeesOutput = '';

      sortedEmployees.forEach(employee => {
         employeesOutput += `Name: ${employee[0]} With Salary: ${employee[1]} `;
      });

      outputWorkers.textContent = employeesOutput.trimEnd();
   }
}