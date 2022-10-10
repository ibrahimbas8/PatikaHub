package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        int kenar1,kenar2,kenar3;
        Scanner input = new Scanner(System.in);
        System.out.print("Birinci kenarı giriniz :");
        kenar1 = input.nextInt();
        System.out.print("ikinci kenarı giriniz :");
        kenar2 = input.nextInt();
        System.out.print("Üçüncü kenarı giriniz :");
        kenar3 = input.nextInt();

        double alan, u;
        u=(kenar1+kenar2+kenar3)/2;
        alan = Math.sqrt (u*(u-kenar1)*(u-kenar2)*(u-kenar3));
        System.out.print("Üç kenarı girilen üçgenin alanı :" + alan);
    }
}
