package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        int sicaklik;
        Scanner input = new Scanner(System.in);

        System.out.print("Sıcaklık değerini giriniz:");
        sicaklik = input.nextInt();

        if (sicaklik<5){
            System.out.println("Kayağa gidebilirsin...");
        }
        if (sicaklik>=5 && sicaklik <=15){
            System.out.println("Sinemaya gidebilirsin...");
        }
        if (sicaklik>=10 && sicaklik <=25){
            System.out.println("Pikniğe gidebilirsin...");
        }
        else if(sicaklik>25){
            System.out.println("Yüzmeye gidebilirsin...");
        }
    }
}
