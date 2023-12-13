import Image from 'next/image'
import { Box, Container, Flex, SimpleGrid } from "@chakra-ui/layout";
import React from "react";
import { MdAccountCircle } from "react-icons/md";


import Link from 'next/link';



import './Header.css'

const Header =() =>{
    return(
        <header className='main-header'>

            <div className='spaceBetween'></div>

            <div className='main-header-options primary'>
                
                <button className='header-button main-page'>Main Page</button>
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
                <Link href="user/create-user">
                    <div className='header-button'>
                        <MdAccountCircle className='account-circle'></MdAccountCircle>
                    </div>
                </Link>
                <button className='header-button'>option 2</button>
                <button className='header-button'>option 2</button>
            </div>

            <div className='spaceBetween'></div>

        </header>
    );
}

export default Header