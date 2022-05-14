import React, {useState} from "react";
import style from "./economyQuestion.module.css";
import CultureQuestions from "../CultureQuestions";

const EconomyQuestions = (props) => {

    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [fifthQuestion, setFifthQuestion] = useState(false);
    const [job, setJob] = useState("");

    const jobs = [
        " Managerial jobs",

        " Engineering jobs (except IT, computer engineering, etc.)",

        "IT, Developer and Computer Eng.",

        "Public jobs (requires a license such as taxi driver, electrical technician, etc.)",

        "Public jobs (without the need for a license such as restaurant worker, cashier, etc.)",

        "Lawyers and legal professions",

        "General Practitioner",

        "specialist"
    ]

    return (
        <React.Fragment>
            {
                !fifthQuestion ? (
                    <div className={` col-lg-12 ${style.questionBody}`}>
                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                In which of the following job areas is your specialty?
                                            </p>
                                        </div>
                                        <div className={`${!props.isMobile ? style.chooseJob:style.chooseJobM} mt-5 mb-5`}>
                                            <select value={job}
                                                    onChange={(event) => setJob(event.target.value)} required>
                                                <option value="انتخاب کشوراول" selected>choose your job</option>
                                                {
                                                    jobs.map(item => <option value={item}>{item}</option>)
                                                }
                                            </select>
                                        </div>
                                        {
                                            job === "" ?
                                                <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>next
                                                    </button>
                                                </div>
                                                :
                                                <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                        onClick={() => setFirstQuestion(true)}>next
                                                    </button>
                                                </div>
                                        }
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                In what field do you want to work in the destination country?
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.jobPosition : style.jobPositionM} mt-5 mb-5 ${!props.isMobile ? " ":`row`}`}>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>Just In my job and specialization
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}> Preferably in my job and specialty
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>it does not matter
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>In a particular profession different from my previous experience
                                                </button>
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
                                                How much do you expect to save annually?
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.salary : style.salaryM} mt-5 mb-5 ${!props.isMobile ? " ": `row`}`}>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>More than 50000 dollars
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Between 20000 and 50000 dollars
                                                    (4)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Between 10000 and 20000 dollars
                                                    (3)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Between 5000 and 10000 dollars
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>Under 5000
                                                </button>
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
                                                How much do you currently save annually in your country of origin?
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.salary : style.salaryM} mt-5 mb-5 ${!props.isMobile ? " ": `row`}`}>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>More than 50000 dollars
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>Between 20000 and 50000 dollars
                                                    (4)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>Between 10000 and 20000 dollars
                                                    (3)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>Between 5000 and 10000 dollars
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>Under 5000
                                                </button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setThirdQuestion(false)}> previous
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : !fifthQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                What are the costs for immigration work such as translation of documents,
                                                visa fee, ticket, possible cost of the first few months of living in the destination country?
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.salary : style.salaryM} mt-5 mb-5 ${!props.isMobile ? " ": `row`}`}>
                                            <div>
                                                <button onClick={() => setFifthQuestion(true)}>More than 50000 dollars
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFifthQuestion(true)}>Between 20000 and 50000 dollars
                                                    (4)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFifthQuestion(true)}>Between 10000 and 20000 dollars
                                                    (3)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFifthQuestion(true)}>Between 5000 and 10000 dollars
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFifthQuestion(true)}>Under 5000
                                                </button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setForthQuestion(false)}>previous
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : null
                            }
                        </div>
                    </div>
                ) : (
                   <CultureQuestions isMobile={props.isMobile}/>
                )
            }
        </React.Fragment>
    )
}
export default EconomyQuestions;