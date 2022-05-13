import React from "react";

import logo from "../../../static/header/logo.jpeg"

import style from "./header.module.css";

const Header = (props) => {

    return (
        <React.Fragment>
            <div className="container col-lg-12 col-sm-12">
                <div className={`row ${style.header}`}>
                    <div className={`col-lg-6 col-sm-6 ${style.header_leftSide}`}>
                        <img
                            src={logo}
                            alt="logo"/>
                        <span>Mentors</span>
                        <span>Blogs</span>
                        <span>About</span>
                    </div>
                    {/*<div className={`col-lg-4 col-sm-4 ${style.header_rightSide}`}>*/}
                    {/*    <span>Explore</span>*/}
                    {/*</div>*/}
                </div>
            </div>
        </React.Fragment>
    )
}
export default Header;