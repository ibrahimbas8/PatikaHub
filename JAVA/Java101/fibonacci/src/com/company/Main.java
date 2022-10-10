package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        int seri,a=0,b=1,c;
        Scanner input = new Scanner(System.in);

        System.out.print("Kaç basamak devam etsin giriniz : ");
        seri = input.nextInt();

        for (int i=0;i<seri;i++){
            c= a + b;
            System.out.println(a + " + " + b + " = " + c);
            a = b;
            b = c;
        }
    }
}
