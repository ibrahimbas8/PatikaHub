package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        double sayi1,sayi2;
        int islem;
        Scanner input = new Scanner(System.in);

        System.out.print("Sayi 1 giriniz : ");
        sayi1 = input.nextDouble();
        System.out.print("Sayi 2 giriniz : ");
        sayi2 = input.nextDouble();

        System.out.println("Yapmak istediğiniz işlemi giriniz /n( 1- Toplama 2- Çıkarma 3- Çarpma 4- Bölme: ");
        islem = input.nextInt();



        switch (islem){
            case 1:
                System.out.println("Sonuç : " + (sayi1 + sayi2));
                break;
            case 2:
                System.out.println("Sonuç : " + (sayi1 - sayi2));
                break;
            case 3:
                System.out.println("Sonuç : " + (sayi1 * sayi2));
                break;
            case 4:
                System.out.println("Sonuç : " + (sayi1 / sayi2));
                break;
            default:
                System.out.println("Hatalı giriş yaptınız...");
                break;
        }



    }
}
