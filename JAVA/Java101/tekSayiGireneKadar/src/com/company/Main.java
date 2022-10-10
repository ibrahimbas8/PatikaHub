package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int toplam=0,sayi=0;



        while (sayi%2 !=1){

            System.out.println("Sayı giriniz:");
            sayi=input.nextInt();

            if (sayi%4 == 0){
                toplam += sayi;
            }
        }
        System.out.println("Toplam : " + toplam);
    }
}
