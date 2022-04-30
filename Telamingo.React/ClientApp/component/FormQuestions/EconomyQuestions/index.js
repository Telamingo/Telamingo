import React, {useState} from "react";
import style from "./economyQuestion.module.css";
import CultureQuestion from "../CultureQuestions";

const EconomyQuestions = (props) => {

    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [fifthQuestion, setFifthQuestion] = useState(false);
    const [job, setJob] = useState("");

    const jobs = [
        "doctore", "developer", "saler"
    ]

    return (
        <React.Fragment>
            {
                !fifthQuestion ? (
                    <div className={` col-lg-12 ${style.questionBody}`}>
                        <div className={`${style.questionHeader} mt-3`}>
                            <h3>
                                اقتصاد (۵ سوال)
                            </h3>
                            <i className={`${firstQuestion ? style.active : style.deActive}`}> </i>
                            <i className={`${secondQuestion ? style.active : style.deActive}`}> </i>
                            <i className={`${thirdQuestion ? style.active : style.deActive}`}> </i>
                            <i className={`${forthQuestion ? style.active : style.deActive}`}> </i>
                            <i className={`${fifthQuestion ? style.active : style.deActive}`}> </i>
                        </div>
                        <div className={`${style.questionContent} mt-5`} dir='rtl'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3`}>
                                                تخصص شما در کدام یک از حوزه های شغلی زیر می‌باشد؟
                                            </p>
                                        </div>
                                        <div className={`${style.chooseJob} mt-5 mb-5`}>
                                            شغل شما:
                                            <select value={job}
                                                    onChange={() => setJob(event.target.value)} required>
                                                <option value="انتخاب کشوراول" selected>انتخاب شغل</option>
                                                {
                                                    jobs.map(item => <option value={item}>{item}</option>)
                                                }
                                            </select>
                                        </div>
                                        {
                                            job == "" ?
                                                <div className={`${!props.isMobile ? "" : style.mobileButton}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                                :
                                                <div className={`${!props.isMobile ? "" : style.mobileButton}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                        onClick={() => setFirstQuestion(true)}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                        }
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3`}>
                                                بازه سنی خود را وارد کنید:
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.jobPosition : style.jobPositionM} mt-5 mb-5 ${!props.isMobile ? " ":`row`}`}>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>در شغل و تخصصی که دارم
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>ترجیحا در شغل و تخصصی که
                                                    دارم
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}> فرقی نمی کند
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}> در حرفه ای خاص متفاوت
                                                    با تجربه قبلی ام
                                                </button>
                                            </div>
                                        </div>
                                    </React.Fragment>
                                ) : !thirdQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3`}>
                                                دوست دارید (انتظار دارید) در انتهای هر سال چقدر پس انداز کنید؟
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.jobPosition : style.jobPositionM} mt-5 mb-5 ${!props.isMobile ? " ": `row`}`}>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>بیش از 50 هزار دلار (5)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>بین 20 تا 50 هزار دلار
                                                    (4)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}> بین 10 تا 20 هزار دلار
                                                    (3)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>بین 5 تا 10 هزار دلار (2)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>زیر 5 هزار دلار (1)
                                                </button>
                                            </div>
                                        </div>
                                    </React.Fragment>
                                ) : !forthQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3`}>
                                                در حال حاضر در کشور مبداء سالانه چقدر پس‌انداز می‌کنید؟
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.jobPosition : style.jobPositionM} mt-5 mb-5 ${!props.isMobile ? " ": `row`}`}>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>بیش از 50 هزار دلار (5)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>بین 20 تا 50 هزار دلار
                                                    (4)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}> بین 10 تا 20 هزار دلار
                                                    (3)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>بین 5 تا 10 هزار دلار (2)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>زیر 5 هزار دلار (1)
                                                </button>
                                            </div>
                                        </div>
                                    </React.Fragment>
                                ) : !fifthQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3`}>
                                                برای انجام کارهای مهاجرت مانند ترجمه مدارک، هزینه ویزا، بلیط، هزینه
                                                احتمالی چند ماه اول زندگی در کشور مقصد چه هزینه‌ای در نظر گرفته‌اید؟
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.jobPosition : style.jobPositionM} mt-5 mb-5 ${!props.isMobile ? " ": `row`}`}>
                                            <div>
                                                <button onClick={() => setFifthQuestion(true)}>بیش از 50 هزار دلار (5)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFifthQuestion(true)}>بین 20 تا 50 هزار دلار
                                                    (4)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFifthQuestion(true)}> بین 10 تا 20 هزار دلار
                                                    (3)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFifthQuestion(true)}>بین 5 تا 10 هزار دلار (2)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFifthQuestion(true)}>زیر 5 هزار دلار (1)
                                                </button>
                                            </div>
                                        </div>
                                    </React.Fragment>
                                ) : null
                            }
                        </div>
                    </div>
                ) : (
                   <CultureQuestion isMobile={props.isMobile}/>
                )
            }
        </React.Fragment>
    )
}
export default EconomyQuestions;