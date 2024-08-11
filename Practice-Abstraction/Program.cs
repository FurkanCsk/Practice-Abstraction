using Practice_Abstraction;

// Creating instances of different employee roles

Company softwareDeveloper = new SoftwareDeveloper { Name = "Furkan", Surname = "Coşkun", Department = "Software" };
Company projectManager = new ProjectManager { Name = "Hasan", Surname = "Çıldırmış", Department = "Project" };
Company salesManager = new SalesManager { Name = "Canberk", Surname = "Doğan", Department = "Sales" };


// Displaying each employee's role

softwareDeveloper.Mission();
projectManager.Mission();
salesManager.Mission();

