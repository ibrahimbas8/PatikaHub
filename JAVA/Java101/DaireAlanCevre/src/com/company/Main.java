package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        int r,a;
        double  alan, cevre, pi=3.14, dilimAlan;
        Scanner input = new Scanner(System.in);
        System.out.print("Daire yarı çapı giriniz : ");
        r= input.nextInt();

        alan= pi * r * r;
        System.out.println("Daire Alanı:" + alan);

        cevre = 2 * pi * r;
        System.out.println("Daire Çevresi: " + cevre);

        System.out.print("Hesaplanacak açıyı giriniz : ");
        a= input.nextInt();

        dilimAlan = (pi * (r * r) * a)/360;
        System.out.println("Daire dilimi alanı : " + dilimAlan);
    }
}
