public class Employee {
    String name;
    double salary;
    int workHours;
    int hireYear;
    double taxPer = 0.03;
    double taxSalary;
    int bonusSalary = 30;
    int bonusAmount;
    int nowYear = 2021;
    int raise;

    public Employee(String name,double salary, int workHours, int hireYear){
        this.name = name;
        this.salary = salary;
        this.workHours = workHours;
        this.hireYear = hireYear;
    }
    public double tax(){
        if (salary>0 && salary<1000){
            return salary;
        }
        else{
            taxSalary += salary * taxPer;
            return salary - taxSalary;
        }
    }

    public double bonus(){
        if (workHours>40){
            int bonusTime = workHours -40 ;
            bonusAmount += bonusTime * bonusSalary;
            return  salary + bonusAmount;
        }
        else{
            return salary;
        }
    }

    public double raiseSalary(){
        int year = nowYear - hireYear;
        if (year<10){
            raise+= salary * 0.05;
            return salary + raise;
        }
        else if(year>= 10 && year<20){
            raise+= salary * 0.10;
            return salary+raise;
        }
        else {
            raise+= salary * 0.15;
            return salary +raise;
        }
    }

    public void printEmployee(){
        System.out.println("Adı : " + this.name);
        System.out.println("Maaşı : " + this.salary);
        System.out.println("Çalışma Saati : " + this.workHours);
        System.out.println("Başlangıç Yılı : " + this.hireYear);
        System.out.println("Vergi : " +  taxSalary);
        System.out.println("Bonus : " +  bonusAmount);
        System.out.println("Maaş artışı : " + raise);
        System.out.println("Vergi ve bonuslar ile birlikte : " + (salary+bonusAmount-taxSalary));
        System.out.println("Toplam maaş : " + ( salary+ bonusAmount+ raise- taxSalary));
    }

}
