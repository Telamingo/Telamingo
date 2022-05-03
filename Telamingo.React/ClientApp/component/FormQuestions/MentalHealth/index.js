import React, {useState} from "react";
import style from "./mentalHealth.module.css";
import {event} from "next/dist/build/output/log";
import EnvironmentQuestions from "../EnvironmentQuestions";

const MentalHealth = (props) => {

    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [haveMentalSick, setHaveMentalSick] = useState(false);
    const [mentalProblem, setMentalProblem] = useState([]);

    function checkMentalProblem(event) {

        setMentalProblem((mentalProblem) => [...mentalProblem, event.target.value])
        console.log(mentalProblem);
    }

    return (
        <React.Fragment>
            {
                !secondQuestion ?
                    <div className={` col-lg-12 ${style.questionBody}`}>
                        <div className={`${style.questionHeader} mt-3`}>
                            <h3>
                                سلامت روانی (۲ سوال)
                            </h3>
                            <i className={`${firstQuestion ? style.active : style.deActive}`}> </i>
                            <i className={`${secondQuestion ? style.active : style.deActive}`}> </i>
                        </div>
                        <div className={`${style.questionContent} mt-5`} dir='rtl'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        {
                                            !haveMentalSick ? (
                                                <React.Fragment>
                                                    <div>
                                                        <p className={`${style.questionTitle}`}>
                                                            شما یا اعضای خانواده (در صورت مهاجرت به صورت خانوادگی) سابقه
                                                            درگیری با بیماری روحی خاصی را دارید؟
                                                        </p>
                                                    </div>
                                                    <div className={` ${!props.isMobile ? style.haveMentalSick : style.haveMentalSickM} mt-3 ${!props.isMobile  ? " " : `row`}`}>
                                                        <div>
                                                            <button onClick={() => setFirstQuestion(true)}>خیر</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setHaveMentalSick(true)}>بله</button>
                                                        </div>
                                                    </div>
                                                </React.Fragment>
                                            ) : (
                                                <React.Fragment>
                                                    <div>
                                                        <p className={`${style.questionTitle}`}>
                                                            سابقه بیماری شما :
                                                        </p>
                                                        <p className={`${style.questionDsc}`}>
                                                            (چند گزینه میشه انتخاب کرد، حداکثر سه مورد)
                                                        </p>
                                                    </div>
                                                    <div className={`${!props.isMobile ? style.chooseMentalSick : style.chooseMentalSickM} ${!props.isMobile ? " ":`row`}`}>
                                                        <label>
                                                            <input type="checkbox" value="افسردگی مینور"
                                                                   onChange={checkMentalProblem}/>
                                                            افسردگی مینور
                                                        </label>
                                                        <label>
                                                            <input type="checkbox" value="افسردگی ماژور"
                                                                   onChange={checkMentalProblem}/>
                                                            افسردگی ماژور
                                                        </label>
                                                        <label>
                                                            <input type="checkbox" value="اضطراب"
                                                                   onChange={checkMentalProblem}/>
                                                            اضطراب
                                                        </label>
                                                        <label>
                                                            <input type="checkbox" value="وسواس فکری"
                                                                   onChange={checkMentalProblem}/>
                                                            وسواس فکری
                                                        </label>
                                                        <label>
                                                            <input type="checkbox" value="وسواس عملی"
                                                                   onChange={checkMentalProblem}/>
                                                            وسواس عملی
                                                        </label>
                                                        <label>
                                                            سایر:
                                                            <input type="text"/>
                                                        </label>
                                                    </div>
                                                    {
                                                        mentalProblem == "" ? (
                                                            <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                                <button
                                                                    className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>سوال
                                                                    بعدی
                                                                </button>
                                                            </div>
                                                        ) : (
                                                            <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                                <button
                                                                    className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                    onClick={() => setFirstQuestion(true)}>سوال
                                                                    بعدی
                                                                </button>
                                                            </div>
                                                        )
                                                    }
                                                </React.Fragment>
                                            )
                                        }
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div>
                                            <p className={`${style.questionTitle}`}>
                                                چقدر با والدین خود ارتباط رو در رو دارید؟
                                            </p>
                                            <p className={`${style.questionDsc}`}>
                                                (به دیدار خانواده خود میروید)
                                            </p>
                                        </div>
                                        <div className={` ${style.chooseMeetingRate} mt-3`}>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    با خانواده زندگی میکنم و وابستگی زیادی به ایشان دارم (1)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    با خانواده زندگی میکنم اما وابستگی زیادی به ایشان ندارم (3)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    تقریبا هر روز به آنها سر میزنم یا هم را میبینیم (2)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    هفته 3 تا 5 بار (3)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    به ندرت (ماهی 3 تا 5 بار) (4)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    همین الان هم از هم فاصله زیادی داریم (سالی 2 تا 3 بار) (5)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>
                                                    والدینم فوت شده اند یا آن ها را اصلا نمیبینم (5)
                                                </button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.mobileButton : style.mobileButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setFirstQuestion(false)}>سوال قبلی
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : null
                            }
                        </div>
                    </div>
                    :
                    <EnvironmentQuestions isMobile={props.isMobile}/>
            }
        </React.Fragment>
    )
}

export default MentalHealth;