import Image from 'next/image'
import { Box, Container, Flex, SimpleGrid } from "@chakra-ui/layout";
import React from "react";
import Link from "next/link";
import { Button } from "@chakra-ui/react";
import { MdAccountCircle } from "react-icons/md";




import './Header.css'

const Header =() =>{
    return(
        <header className='main-header'>

            <div className='spaceBetween'></div>

            <div className='main-header-options primary'>
                
                <button className='header-button'>MAIN MENU</button>
                <button className='header-button'>option 1</button>
                <button className='header-button'>option 1</button>
                <button className='header-button'>option 1</button>
                <button className='header-button'>option 1</button>
                
            </div>

            <div className='spaceBetween'></div>
            <div className='spaceBetween'></div>
            <div className='spaceBetween'></div>
            <div className='spaceBetween'></div>
            <div className='spaceBetween'></div>

            <div className='main-header-options second'>
                <button className='header-button'><MdAccountCircle className='account-circle'></MdAccountCircle></button>
                <button className='header-button'>option 2</button>
                <button className='header-button'>option 2</button>
            </div>

            <div className='spaceBetween'></div>

        </header>
    );
}

export default Header