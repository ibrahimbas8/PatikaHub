package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int us,sayi,sonuc=1;

        System.out.print("Üssü alınacak sayı: " );
        sayi = input.nextInt();

        System.out.print("Üs değerini giriniz: " );
        us = input.nextInt();

        for (int i=0; i<us; i++){
            sonuc *= sayi;
        }
        System.out.println("Sonuç : " + sonuc);
    }
}
