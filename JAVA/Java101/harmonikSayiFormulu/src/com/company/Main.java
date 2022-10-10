package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        double sonuc=0;
        System.out.print("Sayı giriniz: ");
        int sayi = input.nextInt();

        for (int i=1; i<=sayi; i++){
            sonuc = sonuc + 1.0/i;
        }
        System.out.println("Harmonik sonuç : " +sonuc);
    }
}
