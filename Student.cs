class Student: Person { 
    private string studentID;

    public Student(string name, string password, string studentID)
    : base(name, password) {
        this.studentID = studentID;
    } 
    
}