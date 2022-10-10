package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        String kullaniciAdi1, kullaniciAdi2, sifre1, sifre2;
        int kalanHak1 = 3, kalanHak2 = 3, islem1, islem2, bakiye1 = 5000, bakiye2 = 5000, paraMiktari1, paraMiktari2;
        Scanner input = new Scanner(System.in);

        System.out.println("\n!!! ATM Projesi (BANKA İŞLEMLERİ / SWITCH-CASE) !!!\n");

        System.out.println("Merhabalar, Kodluyoruz bankasına Hoşgeldiniz!");


        while (kalanHak2 > 0) {
            System.out.print("Kullanıcı Adınız: ");
            kullaniciAdi2 = input.nextLine();
            System.out.print("Şifreniz: ");
            sifre2 = input.nextLine();
            if (kullaniciAdi2.equals("Patika") && sifre2.equals("Dev123")) {
                System.out.println("Sisteme başarılı bir şekilde giriş yaptınız.");


                System.out.println("1 - Bakiye Sorgulama\n" +
                        "2 - Para Yatırma\n" +
                        "3 - Para Çekme\n" +
                        "4 - Çıkış Yap\n");
                System.out.print("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                islem2 = input.nextInt();

                do {
                    switch (islem2) {
                        case 1:
                            System.out.println("Bakiyeniz: " + bakiye2);

                            System.out.println("1 - Bakiye Sorgulama\n" +
                                    "2 - Para Yatırma\n" +
                                    "3 - Para Çekme\n" +
                                    "4 - Çıkış Yap\n");
                            System.out.print("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                            islem2 = input.nextInt();
                            break;

                        case 2:
                            System.out.print("Lütfen yatırmak istediğiniz para miktarını giriniz: ");
                            paraMiktari2 = input.nextInt();
                            bakiye2 += paraMiktari2;
                            System.out.println("Bakiyeniz: " + bakiye2);

                            System.out.println("1 - Bakiye Sorgulama\n" +
                                    "2 - Para Yatırma\n" +
                                    "3 - Para Çekme\n" +
                                    "4 - Çıkış Yap\n");
                            System.out.print("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                            islem2 = input.nextInt();
                            break;

                        case 3:
                            System.out.print("Lütfen çekmek istediğiniz para miktarını giriniz: ");
                            paraMiktari2 = input.nextInt();
                            if (paraMiktari2 > bakiye2) {
                                System.out.println("Bakiyeniz yetersiz.");
                            } else {
                                bakiye2 -= paraMiktari2;
                                System.out.println("Bakiyeniz: " + bakiye2);
                            }

                            System.out.println("1 - Bakiye Sorgulama\n" +
                                    "2 - Para Yatırma\n" +
                                    "3 - Para Çekme\n" +
                                    "4 - Çıkış Yap\n");
                            System.out.print("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                            islem2 = input.nextInt();
                            break;

                        case 4:
                            break;

                        default:
                            System.out.println("1 - Bakiye Sorgulama\n" +
                                    "2 - Para Yatırma\n" +
                                    "3 - Para Çekme\n" +
                                    "4 - Çıkış Yap\n");
                            System.out.print("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                            islem2 = input.nextInt();

                    }
                } while (islem2 != 4);
                System.out.print("İyi günler dileriz.");
                break;

            } else {
                System.out.println("Hatalı kullanıcı adı veya şifre girişi. Kalan hakkınız: " + --kalanHak2);
                if (kalanHak2 == 0) {
                    System.out.println("Hesabınız bloke edilmiştir.");
                }
            }
        }
    }
}
