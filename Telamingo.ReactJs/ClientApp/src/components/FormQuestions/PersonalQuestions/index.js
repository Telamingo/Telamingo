import React, {useState} from "react";
import style from "./personalQuestion.module.css";
import EconomyQuestions from "../EconomyQuestions";

const PersonalQuestions = (props) => {
    const [firstCountry, setFirstCountry] = useState("");
    const [secondCountry, setSecondCountry] = useState("");
    const [thirdCountry, setThirdCountry] = useState("");
    const [progressValue, setProgressValue] = useState(0);
    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [fifthQuestion, setFifthQuestion] = useState(false);
    const [sixQuestion, setSixQuestion] = useState(false);
    const [thirdLang, setThirdLang] = useState(false);
    const [haveFollower, setHaveFollower] = useState(false);
    const [countOfFollowers, setCountOfFollowers] = useState(false);
    const [firstLanLevel, setFirstLanLevel] = useState("");
    const country = [
        "newYork",
        "england",
        "africa",
        "poland"
    ];
console.log(props)
    return (
        <React.Fragment>
            {
                !sixQuestion ? (
                    <div className={` col-lg-12 container ${style.questionBody}`}>
                        <div className={`${style.questionHeader} mt-3`}>
                            <h3>
                                اطلاعات فردی و عمومی (6 سوال)
                            </h3>
                            <i className={`${firstQuestion ? style.active : style.deActive}`}> </i>
                            <i className={`${secondQuestion ? style.active : style.deActive}`}> </i>
                            <i className={`${thirdQuestion ? style.active : style.deActive}`}> </i>
                            <i className={`${forthQuestion ? style.active : style.deActive}`}> </i>
                            <i className={`${fifthQuestion ? style.active : style.deActive}`}> </i>
                            <i className={`${sixQuestion ? style.active : style.deActive}`}> </i>
                        </div>
                        <div className={`${style.questionContent} mt-5`} dir='rtl'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3`}>
                                                به کدام کشور قصد مهاجرت دارید؟
                                            </p>
                                            <p className={`${style.questionDsc}`}>
                                                (به ترتیب الویت وارد کنید)
                                            </p>
                                        </div>
                                        <div className={`${ !props.isMobile ? style.chooseCountry : `row ${style.chooseCountryM}`} mt-5 mb-5`}>
                                            <label>
                                                کشور اول:
                                                <select value={firstCountry}
                                                        onChange={(event) => setFirstCountry(event.target.value)} required>
                                                    <option value="انتخاب کشوراول" selected>انتخاب کشوراول</option>
                                                    {
                                                        country.map(item => secondCountry && item == secondCountry ?
                                                            <option value={item}>کشور
                                                                دوم</option> : thirdCountry && item == thirdCountry ?
                                                                <option value={item}>کشور سوم</option> :
                                                                <option value={item}>{item}</option>)
                                                    }
                                                </select>
                                            </label>
                                            <label>
                                                کشور دوم:
                                                <select value={secondCountry}
                                                        onChange={(event) => setSecondCountry(event.target.value)} required>
                                                    <option value="انتخاب کشوراول" selected>انتخاب کشور دوم</option>
                                                    {
                                                        country.map(item => item == firstCountry ?
                                                            <option value={item}>کشور
                                                                اول</option> : item == thirdCountry ?
                                                                <option value={item}>کشور سوم</option> :
                                                                <option value={item}>{item}</option>)
                                                    }
                                                </select>
                                            </label>
                                            <label>
                                                کشور سوم:
                                                <select value={thirdCountry}
                                                        onChange={(event) => setThirdCountry(event.target.value)} required>
                                                    <option value="انتخاب کشوراول" selected>انتخاب کشور سوم</option>
                                                    {
                                                        country.map(item => item == firstCountry ?
                                                            <option value={item}>کشور
                                                                اول</option> : item == secondCountry ?
                                                                <option value={item}>کشور دوم</option> :
                                                                <option value={item}>{item}</option>)
                                                    }
                                                </select>
                                            </label>
                                        </div>
                                        {
                                            firstCountry == "" ? (
                                                <div className={`${!props.isMobile ? "" : style.mobileButton}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                            ) : (
                                                <div className={`${!props.isMobile ? "" : style.mobileButton}`}>
                                                    <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                            onClick={() => setFirstQuestion(true)}>سوال بعدی
                                                    </button>
                                                </div>
                                            )
                                        }
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3`}>
                                                بازه سنی خود را وارد کنید:
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.chooseAge : style.chooseAgeM} mt-5 mb-5`}>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>بالای 50 سال</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}> بین 35 تا 50 سال
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}> بین 25 تا 35 سال
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}> بین 18 تا 25 سال
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}> زیر 18 سال</button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.mobileButton : style.mobileButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setFirstQuestion(false)}>سوال قبلی
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : !thirdQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3`}>
                                                جنسیت:
                                            </p>
                                        </div>
                                        <div className={`${!props.isMobile ? style.chooseAge : style.chooseAgeM} mt-5 mb-5`}>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>زن</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}> مرد</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}> سایر</button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.mobileButton : style.mobileButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setSecondQuestion(false)}>سوال قبلی
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : !forthQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3`}>
                                                وضعیت تاهل:
                                            </p>
                                        </div>
                                        <div className={`${!props.isMobile ? style.chooseAge : style.chooseAgeM} mt-5 mb-5`}>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>مجرد</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}> متاهل</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}> طلاق</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}> بیوه</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}> سایر</button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.mobileButton : style.mobileButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setThirdQuestion(false)}>سوال قبلی
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : !fifthQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3`}>
                                                وضعیت زبان:
                                            </p>
                                        </div>
                                        <div className={`${!props.isMobile ? style.language : style.languageM}`}>
                                            <label>
                                                زبان اول:
                                                <select onChange={(event)=>setFirstLanLevel(event.target.value)}>
                                                    <option selected>انتخاب سطح</option>
                                                    <option>عالی</option>
                                                    <option>متوسط</option>
                                                    <option>ضعیف</option>
                                                </select>
                                            </label>
                                            <label>
                                                زبان دوم:
                                                <select>
                                                    <option selected>انتخاب سطح</option>
                                                    <option>عالی</option>
                                                    <option>متوسط</option>
                                                    <option>ضعیف</option>
                                                </select>
                                            </label>
                                            {
                                                thirdLang ? (
                                                    <label>
                                                        زبان سوم:
                                                        <select>
                                                            <option selected>انتخاب سطح</option>
                                                            <option>عالی</option>
                                                            <option>متوسط</option>
                                                            <option>ضعیف</option>
                                                        </select>
                                                    </label>
                                                ) : null
                                            }
                                            <span className={`${!props.isMobile ? style.moreLang : style.moreLangM} mt-5`}
                                                  onClick={() => setThirdLang(true)}>
                                                       درصورت تسلط به زبانی دیگر، کلیک کنید
                                            </span>
                                        </div>
                                        {
                                            firstLanLevel == "" ?
                                                <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                    <button className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>سوال بعدی
                                                    </button>
                                                </div>
                                                :
                                                <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                    <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                            onClick={() => setFifthQuestion(true)}>سوال بعدی
                                                    </button>
                                                </div>
                                        }
                                        <div className={`${!props.isMobile ? style.mobileButton : style.mobileButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setForthQuestion(false)}>سوال قبلی
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : !sixQuestion ? (
                                    <React.Fragment>
                                        {
                                            !haveFollower ? (
                                                <React.Fragment>
                                                    <div className={`mb-3`}>
                                                        <p className={`mt-3`}>
                                                            آیا قصد دارید به تنهایی مهاجرت کنید؟
                                                        </p>
                                                    </div>
                                                    <div className={` ${!props.isMobile ? style.chooseCount : style.chooseCountM} mt-5 mb-5`}>
                                                        <div>
                                                            <button onClick={() => setSixQuestion(true)}> بله</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setHaveFollower(true)}> خیر</button>
                                                        </div>
                                                    </div>
                                                    <div className={`${!props.isMobile ? style.mobileButton : style.mobileButtonM}`}>
                                                        <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                onClick={() => setFifthQuestion(false)}>سوال قبلی
                                                        </button>
                                                    </div>
                                                </React.Fragment>
                                            ) : (
                                                <React.Fragment>
                                                    {
                                                        !countOfFollowers ? (
                                                            <React.Fragment>
                                                                <div className={`mb-3`}>
                                                                    <p className={`mt-3`}>
                                                                        چند نفر در زمان مهاجرت همراه شما خواهند بود؟
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
                                                                <div className={`mb-3`}>
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
                                                                        onClick={() => setSixQuestion(true)}>سوال بعدی
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