import style from "./homePage.module.css";

const HomePage = (props) =>{

    const {isMobile} = props
    return(
        <div className={`container col-lg-12 mt-5 ${style.homePage}`}>
            <div className={`row ${style.content}`}>
                <div className={`col-lg-6`}>
                    <h1 className={`${ !isMobile ? style.content_title : style.content_titleM}`}>set aside the ambiguities with the most reliable rout</h1>
                    <p className={`mt-4 ${!isMobile ? style.content_dsc : style.content_dscM}`}>Telamingo helps you to set aside the ambiguities with
                        the most reliable route based on the experiences of the
                        people with the most similar conditions you have.
                    </p>
                    <div className={`col-lg-12 mt-5`}>
                        <div className={style.selectCountry}>
                            <input className={`col-lg-8`} placeholder="Where do you want to go?"/>
                            <button className={`col-lg-4 ${!isMobile ? style.selectCountryButton : style.selectCountryButtonM}`}>Explore</button>
                        </div>
                    </div>
                </div>
                <div className={`${!isMobile ? `col-lg-6 ${style.homePagePic}` : `mt-3 ${style.homePagePicM}`}`}>
                    <img src="https://takhfifan.com/_next/static/images/Group%205172-1ed0859b45b3fa9b3170a69e9276d256.svg" alt="homePagePic"/>
                </div>
            </div>
        </div>
    )
}

export default HomePage;