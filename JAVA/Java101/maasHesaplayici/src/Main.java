public class Main {
    public static void main(String[] args) {
        Employee employee1= new Employee("Ali",2000,45,1985);
        employee1.tax();
        employee1.bonus();
        employee1.raiseSalary();
        employee1.printEmployee();
    }
}
