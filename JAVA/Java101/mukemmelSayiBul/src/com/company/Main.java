package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        int sayi,tamBolenler=0;
        Scanner input = new Scanner(System.in);

        System.out.print("Sayı giriniz : ");
        sayi = input.nextInt();

        for (int i=1; i<sayi; i++){
            if (sayi%i==0){
                tamBolenler +=i;
            }
        }
        if (sayi == tamBolenler){
            System.out.println(sayi + " mükemmel sayıdır.");
        }else {
            System.out.println(sayi + " mükemmel sayı değildir.");
        }
    }
}
