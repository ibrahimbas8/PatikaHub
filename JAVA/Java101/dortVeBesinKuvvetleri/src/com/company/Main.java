package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int sayi;

        System.out.print("Lütfen bir sınır değeri giriniz: ");
        sayi = input.nextInt();

        System.out.println("4'ün katları");

        for (int i = 1; i <= sayi; i *= 4) {
            System.out.println(i);
        }

        System.out.println("5'in katları");

        for (int i = 1; i <= sayi; i *= 5) {
            System.out.println(i);
        }
    }
}
