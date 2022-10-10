public abstract class Account {
    private User user;

    public final void showUserInfo() {
        System.out.println(" * USER INFO");
        System.out.println("First name: " + "\t" + getUser().getFirstName() + "\n" +
                "Last name: " + "\t\t" + getUser().getLastName() + "\n" +
                "Email: " + "\t\t\t" + getUser().getEmail() + "\n" +
                "Occupation: " + "\t" + getUser().getOccupation() + "\n" +
                "Age: " + "\t\t\t" + getUser().getAge());
        System.out.println("Addresses: ");
        for (Address address : getUser().getAddressList()) {
            System.out.println(" \t\t*" + address.getClass().getName() + ": " + address.getAddress());
        }
        System.out.println("Insurances: ");
        for (Insurance insurance : getInsurances()) {
            insurance.calculate(this);
            System.out.println(" \t\t*" + insurance.getName());
            System.out.println("\t\t\t\t*"+insurance.getPrice()+" TL \n\t\t\t\t"+insurance.getStartingDate()+"\n\t\t\t\t"+insurance.getExpirationDate());
        }
    }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }
}
