package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        double armut=2.14, elma=3.67, domates= 1.11, muz=0.95, patlican=5, total;
        int kgArmut,kgElma,kgDomates,kgMuz, kgPatlican;

        Scanner input = new Scanner(System.in);
        System.out.println("Kaç kg armut istiyorsunuz : ");
        kgArmut = input.nextInt();

        System.out.println("Kaç kg elma istiyorsunuz : ");
        kgElma = input.nextInt();

        System.out.println("Kaç kg domates istiyorsunuz : ");
        kgDomates = input.nextInt();

        System.out.println("Kaç kg muz istiyorsunuz : ");
        kgMuz = input.nextInt();

        System.out.println("Kaç kg patlican istiyorsunuz : ");
        kgPatlican = input.nextInt();

        total = armut*kgArmut + elma*kgElma + domates*kgDomates + muz*kgMuz + patlican*kgPatlican;
        System.out.println("Toplam tutar : " + total + " ₺");
    }
}
