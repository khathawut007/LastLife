class Employee: Person { 
    private string employeeID;

    public Employee(string name, string password, string employeeID)
    : base(name, password) {
        this.employeeID = employeeID;
    } 
    
}