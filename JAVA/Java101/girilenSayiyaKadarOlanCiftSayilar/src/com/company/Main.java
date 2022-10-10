package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Sayı giriniz : ");
        int sayi = input.nextInt();

        for (int i=0; i<=sayi; i++){
            if (i%3==0 && i%4==0){   //12 ile mod alınarakda bulunabilir
                System.out.println("3 ve 4 bölünen sayı : " + i);
            }
        }
    }
}
