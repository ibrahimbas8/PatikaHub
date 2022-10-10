package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    int mat, fizik, turkce, kimya, muzik, dersSayisi=5;
	    double ort;

	    Scanner input = new Scanner(System.in);

        System.out.println("Matematik ders notunuzu giriniz:");
        mat = input.nextInt();

        System.out.println("fizik ders notunuzu giriniz:");
        fizik = input.nextInt();

        System.out.println("turkce ders notunuzu giriniz:");
        turkce = input.nextInt();

        System.out.println("kimya ders notunuzu giriniz:");
        kimya = input.nextInt();

        System.out.println("muzik ders notunuzu giriniz:");
        muzik = input.nextInt();

        if (mat < 0 || mat > 100) {
            mat = 0;
            dersSayisi--;
        }

        if (fizik < 0 || fizik > 100) {
            fizik = 0;
            dersSayisi--;
        }

        if (turkce < 0 || turkce > 100) {
            turkce = 0;
            dersSayisi--;
        }

        if (kimya < 0 || kimya > 100) {
            kimya = 0;
            dersSayisi--;
        }

        if (muzik < 0 || muzik > 100) {
            muzik = 0;
            dersSayisi--;
        }

        ort = (mat + fizik + kimya + turkce + muzik)/dersSayisi;
        if (ort>=55){
            System.out.println("Geçtiniz... " +ort);
        }
        else{
            System.out.println("kaldınız..." +ort);
        }
    }
}
