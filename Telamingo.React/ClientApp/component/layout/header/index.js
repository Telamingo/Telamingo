import React, {useState} from "react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {faBars, faClose} from "@fortawesome/free-solid-svg-icons";

import style from "./header.module.css";

const Header = (props) => {

    const [isMenuOpen, setIsMenuOpen] = useState(false)

    const {isMobile} = props

    const showMenu = () => {
        setIsMenuOpen(!isMenuOpen)
    }

    return (
        <React.Fragment>
            {
                !isMobile ? (
                    <div className="container col-lg-12 col-sm-12 mt-3">
                        <div className={`row ${style.header}`}>
                            <div className={`col-lg-8 col-sm-8 ${style.header_leftSide}`}>
                                <img
                                    src="	https://www.opencare.com/images/brand/opencare-logo-cross-and-text-charcoal.svg"
                                    alt="logo"/>
                                <span>Mentors</span>
                                <span>Blogs</span>
                                <span>About</span>
                            </div>
                            <div className={`col-lg-4 col-sm-4 ${style.header_rightSide}`}>
                                <span>Explore</span>
                            </div>
                        </div>
                    </div>
                ) : (
                    <div className={`container`}>
                        <div className={`row ${style.headerM}`}>
                            <div className={`col-6`}>
                                <img
                                    src="	https://www.opencare.com/images/brand/opencare-logo-cross-and-text-charcoal.svg"
                                    alt="logo"/>
                            </div>
                            <div className={`col-6`} onClick={showMenu}>
                                {
                                    !isMenuOpen ?  <FontAwesomeIcon
                                        icon={faBars}
                                        style={{fontSize: 40, color: "grey"}}
                                    /> :  <FontAwesomeIcon
                                        icon={faClose}
                                        style={{fontSize: 40, color: "grey"}}
                                    />
                                }
                                {/*<span>Explore</span>*/}
                            </div>
                        </div>
                        {
                            isMenuOpen && (
                                <div className={`row ${style.menu}`}>
                                    <ul>
                                        <li>Mentors</li>
                                        <li>Blogs</li>
                                        <li>About</li>
                                        <li className={style.exploreButton}>Explore</li>
                                    </ul>
                                </div>
                            )
                        }
                    </div>
                )
            }
        </React.Fragment>
    )
}
export default Header;