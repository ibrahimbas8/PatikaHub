package com.company;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        double fiyat;
        System.out.print("Fiyatı giriniz: ");
        fiyat = input.nextDouble();

        boolean kdvHesap = fiyat >= 1000;
        System.out.println("KDV tutarı " + (kdvHesap==true ? "%18 : " + fiyat* 0.18: "%8 : " + fiyat* 0.08));
    }
}
