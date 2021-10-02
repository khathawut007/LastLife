class Person{
    protected string name;
    protected string password;

    public Person(string name, string password){
        this.name = name;
        this.password = password;
    }

    public string GetName(){
        return this.name;
    }

}