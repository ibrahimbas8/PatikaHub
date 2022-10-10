package com.company;

import java.util.Comparator;

public class OrderBookPageNumberComparator implements Comparator<Book> {

    @Override
    public int compare(Book o1, Book o2) {
        return o1.getBookPageNumber() - o2.getBookPageNumber();
    }
}
