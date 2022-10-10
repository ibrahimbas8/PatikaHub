package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        int kilo;
        double boy,vki;
        Scanner input = new Scanner(System.in);

        System.out.print("Lütfen boyunuzu (metre cinsinde) giriniz : ");
        boy = input.nextDouble();

        System.out.print("Lütfen kilonuzu giriniz : ");
        kilo = input.nextInt();

        vki = kilo / (boy * boy);
        System.out.println("Vücut kitle indeksiniz: " + vki);
    }
}
