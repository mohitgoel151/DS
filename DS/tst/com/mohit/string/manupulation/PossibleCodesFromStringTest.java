package com.mohit.string.manupulation;

import static org.junit.Assert.*;

import org.junit.Test;

public class PossibleCodesFromStringTest {
	
	PossibleCodesFromString codes = new PossibleCodesFromString();
	
	@Test
	public void decodeTest() {
		assertEquals(5, codes.decode("1123", false).size());
		assertEquals(1, codes.decode("1020", false).size());
		assertEquals(1, codes.decode("333", false).size());
		assertEquals(1, codes.decode("28", false).size());
		assertEquals(0, codes.decode("", false).size());
		assertEquals(1, codes.decode("10", false).size());
		assertEquals(1, codes.decode("20", false).size());
		
		
		assertEquals(5, codes.decode("1123", true).size());
		assertEquals(5, codes.decode("1020", true).size());
		assertEquals(1, codes.decode("333", true).size());
		assertEquals(1, codes.decode("28", true).size());
		assertEquals(0, codes.decode("", true).size());
		assertEquals(2, codes.decode("10", true).size());
		assertEquals(2, codes.decode("20", true).size());
	}

}
