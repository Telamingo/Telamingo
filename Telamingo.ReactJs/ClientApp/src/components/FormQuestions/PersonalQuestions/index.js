import React, {useState} from "react";
import style from "./personalQuestion.module.css";
import EconomyQuestions from "../EconomyQuestions";

const PersonalQuestions = (props) => {
    const [firstCountry, setFirstCountry] = useState("");
    // const [secondCountry, setSecondCountry] = useState("");
    // const [thirdCountry, setThirdCountry] = useState("");
    // const [progressValue, setProgressValue] = useState(0);
    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [fifthQuestion, setFifthQuestion] = useState(false);
    // const [sixQuestion, setSixQuestion] = useState(false);
    const [thirdLang, setThirdLang] = useState(false);
    const [haveFollower, setHaveFollower] = useState(false);
    const [countOfFollowers, setCountOfFollowers] = useState(false);
    const [firstLanLevel, setFirstLanLevel] = useState("");

console.log(props)
    return (
        <React.Fragment>
            {
                !fifthQuestion ? (
                    <div className={` col-lg-12 container ${style.questionBody}`}>
                        {/*<div className={`${style.questionHeader} mt-3`}>*/}
                        {/*    <h3>*/}
                        {/*        اطلاعات فردی و عمومی (6 سوال)*/}
                        {/*    </h3>*/}
                        {/*    <i className={`${firstQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*    <i className={`${secondQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*    <i className={`${thirdQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*    <i className={`${forthQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*    <i className={`${fifthQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*    <i className={`${sixQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*</div>*/}
                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                            {
                                // !firstQuestion ? (
                                //     <React.Fragment>
                                //         <div className={`mb-3 col-12 ${style.question}`}>
                                //             <p className={`mt-3`}>
                                //                 Which country are you going to immigrate to?
                                //             </p>
                                //             <p className={`${style.questionDsc}`}>
                                //                 (States and provinces of Canada and the United States must also be specified)
                                //             </p>
                                //         </div>
                                //         <div className={`${ !props.isMobile ? `col-12 ${style.chooseCountry}` : `row ${style.chooseCountryM}`} mt-5 mb-5`}>
                                //             <label className={style.chooseCountryLabel}>
                                //                 <select value={firstCountry} className={style.chooseCountrySelect}
                                //                         onChange={(event) => setFirstCountry(event.target.value)} required>
                                //                     <option value="انتخاب کشوراول" selected>choose your country</option>
                                //                     {
                                //                         country.map(item => <option value={item}>{item}</option>)
                                //                     }
                                //                 </select>
                                //             </label>
                                //         </div>
                                //         {
                                //             firstCountry === "" ? (
                                //                 <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                //                     <button
                                //                         className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>
                                //                         next
                                //                     </button>
                                //                 </div>
                                //             ) : (
                                //                 <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                //                     <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                //                             onClick={() => setFirstQuestion(true)}>next
                                //                     </button>
                                //                 </div>
                                //             )
                                //         }
                                //     </React.Fragment>
                                // ) :
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                How old are you?
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.chooseAge : style.chooseAgeM} mt-5 mb-5`}>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>Over 50 years</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>Between 35 and 49 years
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>Between 25 and 34 years
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}> Between 18 and 24 years
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>Under 18 years</button>
                                            </div>
                                        </div>
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3  ${style.question}`}>
                                            <p className={`mt-3`}>
                                                What is your Sex?
                                            </p>
                                        </div>
                                        <div className={`${!props.isMobile ? style.chooseAge : style.chooseAgeM} mt-5 mb-5`}>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>Man</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>Woman</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>Other</button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setFirstQuestion(false)}>previous
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : !thirdQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                Marital Status:
                                            </p>
                                        </div>
                                        <div className={`${!props.isMobile ? style.chooseAge : style.chooseAgeM} mt-5 mb-5`}>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Single</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Married</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Seperated</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Divorced</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Widow</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Other</button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setSecondQuestion(false)}>previous
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : !forthQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                Language Status:
                                            </p>
                                        </div>
                                        <div className={`${!props.isMobile ? style.language : style.languageM}`}>
                                            <label>
                                               first language:
                                                <select onChange={(event)=>setFirstLanLevel(event.target.value)}>
                                                    <option selected>choose your level</option>
                                                    <option>Advance</option>
                                                    <option>Intermediate</option>
                                                    <option>Beginner</option>
                                                </select>
                                            </label>
                                            <label>
                                                second language:
                                                <select>
                                                    <option selected>choose your level</option>
                                                    <option>Advance</option>
                                                    <option>Intermediate</option>
                                                    <option>Beginner</option>
                                                </select>
                                            </label>
                                            {
                                                thirdLang ? (
                                                    <label>
                                                       third language:
                                                        <select>
                                                            <option selected>choose your level</option>
                                                            <option>Advance</option>
                                                            <option>Intermediate</option>
                                                            <option>Beginner</option>
                                                        </select>
                                                    </label>
                                                ) : null
                                            }
                                            <span className={`${!props.isMobile ? style.moreLang : style.moreLangM} mt-5`}
                                                  onClick={() => setThirdLang(true)}>
                                                      Do you know any more question?
                                            </span>
                                        </div>
                                        <div className={`col-12 ${style.buttons}`}>
                                            <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                        onClick={() => setThirdQuestion(false)}>previous
                                                </button>
                                            </div>
                                            {
                                                firstLanLevel === "" ?
                                                    <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                        <button className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>next
                                                        </button>
                                                    </div>
                                                    :
                                                    <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                        <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                onClick={() => setForthQuestion(true)}>next
                                                        </button>
                                                    </div>
                                            }
                                        </div>
                                    </React.Fragment>
                                ) : !fifthQuestion ? (
                                    <React.Fragment>
                                        {
                                            !haveFollower ? (
                                                <React.Fragment>
                                                    <div className={`mb-3 ${style.question}`}>
                                                        <p className={`mt-3`}>
                                                            Are you planning to immigrate alone?
                                                        </p>
                                                    </div>
                                                    <div className={` ${!props.isMobile ? style.chooseCount : style.chooseCountM} mt-5 mb-5`}>
                                                        <div>
                                                            <button onClick={() => setFifthQuestion(true)}>Yes</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setHaveFollower(true)}>No</button>
                                                        </div>
                                                    </div>
                                                    <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                        <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                onClick={() => setForthQuestion(false)}>previous
                                                        </button>
                                                    </div>
                                                </React.Fragment>
                                            ) : (
                                                <React.Fragment>
                                                    {
                                                        !countOfFollowers ? (
                                                            <React.Fragment>
                                                                <div className={`mb-3 ${style.question}`}>
                                                                    <p className={`mt-3`}>
                                                                        How many person are be with you?
                                                                    </p>
                                                                </div>
                                                                <div className={`${!props.isMobile ? style.chooseCount : style.chooseCountM} mt-5 mb-5`}>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => setCountOfFollowers(true)}>1
                                                                        </button>
                                                                    </div>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => setCountOfFollowers(true)}>2
                                                                        </button>
                                                                    </div>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => setCountOfFollowers(true)}>3
                                                                        </button>
                                                                    </div>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => setCountOfFollowers(true)}>4
                                                                        </button>
                                                                    </div>
                                                                </div>
                                                            </React.Fragment>
                                                        ) : (
                                                            <React.Fragment>
                                                                <div className={`mb-3 ${style.question}`}>
                                                                    <p className={`mt-3`}>
                                                                        همراه اول چه نسبتی با شما دارد؟
                                                                    </p>
                                                                </div>
                                                                <div className={` ${style.followers} mt-5 mb-5 ${!props.isMobile ? " ": `row`}`}>
                                                                    <label>
                                                                        <input type="radio" value="wife"/>
                                                                        همسر
                                                                    </label>
                                                                    <label>
                                                                        <input type="radio" value="wife"/>
                                                                        پدر و مادر
                                                                    </label>
                                                                    <label>
                                                                        <input type="radio" value="wife"/>
                                                                        خواهر و برادر
                                                                    </label>
                                                                    <label>
                                                                        <input type="radio" value="wife"/>
                                                                        فرزند
                                                                    </label>
                                                                    <label>
                                                                        سایر:
                                                                        <textarea/>
                                                                    </label>
                                                                </div>
                                                                <div className={`mb-3`}>
                                                                    <p className={`mt-3`}>
                                                                        بازه سنی همزاه اول را وارد کنید:
                                                                    </p>
                                                                </div>
                                                                <div className={` ${!props.isMobile ? style.followers : style.followersM} mt-5 mb-5`}>
                                                                    <label>
                                                                        <input type="radio" value="wife"/>
                                                                        بالای ۵۰ سال
                                                                    </label>
                                                                    <label>
                                                                        <input type="radio" value="wife"/>
                                                                        بین ۳۰ تا ۵۰ سال
                                                                    </label>
                                                                    <label>
                                                                        <input type="radio" value="wife"/>
                                                                        بین ۲۰ تا ۳۰
                                                                    </label>
                                                                    <label>
                                                                        <input type="radio" value="wife"/>
                                                                        بین ۱۰ تا ۲۰
                                                                    </label>
                                                                    <label>
                                                                        <input type="radio" value="wife"/>
                                                                        کودک ۳تا ۵ سال
                                                                    </label>
                                                                    <label>
                                                                        <input type="radio" value="wife"/>
                                                                        نوزاد(زیر سه سال)
                                                                    </label>
                                                                </div>
                                                                <div className={`mb-3`}>
                                                                    <p className={`mt-3`}>
                                                                        جنسیت همراه اول را مشخص کنید:
                                                                    </p>
                                                                </div>
                                                                <div className={` ${style.followers} mt-5 mb-5`}>
                                                                    <label>
                                                                        <input type="radio" value="wife"/>
                                                                        زن
                                                                    </label>
                                                                    <label>
                                                                        <input type="radio" value="wife"/>
                                                                        مرد
                                                                    </label>
                                                                    <label>
                                                                        <input type="radio" value="wife"/>
                                                                        سایر
                                                                    </label>
                                                                </div>
                                                                <div className={`mb-3`}>
                                                                    <p className={`mt-3`}>
                                                                        وضعیت زبان همراه اول:
                                                                    </p>
                                                                </div>
                                                                <div className={`mb-3`}>
                                                                    <p className={`mt-3`}>
                                                                        شغل و تخصص:
                                                                    </p>
                                                                </div>
                                                                <div className={`${!props.isMobile ? "" : style.mobileButton}`}>
                                                                    <button
                                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                        onClick={() => setFifthQuestion(true)}>سوال بعدی
                                                                    </button>
                                                                </div>
                                                            </React.Fragment>
                                                        )
                                                    }
                                                </React.Fragment>
                                            )
                                        }
                                    </React.Fragment>
                                ) : null
                            }
                        </div>
                    </div>
                ) : (
                    <EconomyQuestions isMobile={props.isMobile}/>
                )
            }
        </React.Fragment>
    )
}
export default PersonalQuestions;