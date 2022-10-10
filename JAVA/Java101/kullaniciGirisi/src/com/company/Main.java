package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    String userName,password,dbUserName = "ibrahim",dbPassword = "123456",newPassword;

        Scanner input = new Scanner(System.in);

        System.out.print("Kullanıcı Adı giriniz: ");
        userName = input.nextLine();

        System.out.print("Şifre giriniz: ");
        password = input.nextLine();
        if (userName.equals("dbUserName")){
            if (password.equals("dbPassword")){
                System.out.println("Giriş yaptınız");
            }
            else {
                System.out.println("Bilgiler yanlış");
                System.out.print("Şifrenizi sıfırlamak isterseniz 1 e basınız : ");
                int sifirla = input.nextInt();
                if (sifirla == 1){
                    System.out.println("Yanlış girdiğiniz şifre ve eski şifrenizle aynı olmayan bir şifre giriniz:");
                    newPassword = input.next();
                    if (newPassword.equals(password) || newPassword.equals(dbPassword)){
                        System.out.println("Şifre oluşturulamadı, lütfen başka şifre giriniz...");
                    }
                    else{
                        System.out.println("Şifre oluşturuldu");
                    }
                }
                else{
                    System.out.println("Şifre sıfırlamama talebiniz alınmıştır.");
                }
            }
        }
        else{
            System.out.println("Kullanıcı adı hatalı...");
        }


    }
}
